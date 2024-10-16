// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EnsureThat;
using Hl7.Fhir.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Health.Api.Features.Audit;
using Microsoft.Health.Core.Features.Context;
using Microsoft.Health.Fhir.Api.Configs;
using Microsoft.Health.Fhir.Api.Features.ActionResults;
using Microsoft.Health.Fhir.Api.Features.Filters;
using Microsoft.Health.Fhir.Api.Features.Headers;
using Microsoft.Health.Fhir.Api.Features.Routing;
using Microsoft.Health.Fhir.Core.Configs;
using Microsoft.Health.Fhir.Core.Exceptions;
using Microsoft.Health.Fhir.Core.Extensions;
using Microsoft.Health.Fhir.Core.Features;
using Microsoft.Health.Fhir.Core.Features.Context;
using Microsoft.Health.Fhir.Core.Features.Operations;
using Microsoft.Health.Fhir.Core.Features.Operations.Export;
using Microsoft.Health.Fhir.Core.Features.Routing;
using Microsoft.Health.Fhir.Core.Messages.EvaluateMeasure;
using Microsoft.Health.Fhir.Core.Messages.Export;
using Microsoft.Health.Fhir.Core.Models;
using Microsoft.Health.Fhir.Core.Registration;
using Microsoft.Health.Fhir.TemplateManagement.Models;
using Microsoft.Health.Fhir.ValueSets;
using Microsoft.Identity.Client;

namespace Microsoft.Health.Fhir.Api.Controllers
{
    [ServiceFilter(typeof(AuditLoggingFilterAttribute))]
    [ServiceFilter(typeof(OperationOutcomeExceptionFilterAttribute))]
    [ValidateModelState]
    public class EvaluateMeasureController : Controller
    {
        private readonly IMediator _mediator;
        private readonly RequestContextAccessor<IFhirRequestContext> _fhirRequestContextAccessor;
        private readonly IUrlResolver _urlResolver;
        private readonly ExportJobConfiguration _exportConfig;
        private readonly ConvertDataConfiguration _convertConfig;
        private readonly ArtifactStoreConfiguration _artifactStoreConfig;
        private readonly FeatureConfiguration _features;
        private readonly IFhirRuntimeConfiguration _fhirConfig;

        public EvaluateMeasureController(
            IMediator mediator,
            RequestContextAccessor<IFhirRequestContext> fhirRequestContextAccessor,
            IUrlResolver urlResolver,
            IOptions<OperationsConfiguration> operationsConfig,
            IOptions<ArtifactStoreConfiguration> artifactStoreConfig,
            IOptions<FeatureConfiguration> features,
            IFhirRuntimeConfiguration fhirConfig)
        {
            EnsureArg.IsNotNull(mediator, nameof(mediator));
            EnsureArg.IsNotNull(fhirRequestContextAccessor, nameof(fhirRequestContextAccessor));
            EnsureArg.IsNotNull(urlResolver, nameof(urlResolver));
            EnsureArg.IsNotNull(artifactStoreConfig, nameof(artifactStoreConfig));
            EnsureArg.IsNotNull(operationsConfig?.Value?.Export, nameof(operationsConfig));
            EnsureArg.IsNotNull(features?.Value, nameof(features));
            EnsureArg.IsNotNull(fhirConfig, nameof(fhirConfig));

            _mediator = mediator;
            _fhirRequestContextAccessor = fhirRequestContextAccessor;
            _urlResolver = urlResolver;
            _exportConfig = operationsConfig.Value.Export;
            _convertConfig = operationsConfig.Value.ConvertData;
            _artifactStoreConfig = artifactStoreConfig.Value;
            _features = features.Value;
            _fhirConfig = fhirConfig;
        }

        [HttpGet]
        [Route(KnownRoutes.EvaluateMeasureResourceType)]

        // [ServiceFilter(typeof(ValidateExportRequestFilterAttribute))]
        [AuditEventType(AuditEventSubType.EvaluateMeasure)]
        public async Task<IActionResult> EvaluateMeasure(
            [FromQuery(Name = "id")] string id,
            [FromQuery(Name = "subject")] string subject)
        {
            return await SendEvaluateMeasureRequest(id, subject);
        }

        [HttpGet]
        [Route(KnownRoutes.EvaluateMeasureInstance, Name = RouteNames.GetEvaluateMeasureStatusById)]
        [AuditEventType(AuditEventSubType.EvaluateMeasure)]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<IActionResult> GetEvaluateMeasureStatusById(long idParameter)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            return Ok("Routed Successfully");
        }

        private async Task<IActionResult> SendEvaluateMeasureRequest(
            string id,
            string subject)
        {
            CreateEvaluateMeasureResponse response = await _mediator.EvaluateMeasureAsync(
                _fhirRequestContextAccessor.RequestContext.Uri,
                id,
                subject,
                HttpContext.RequestAborted);

            // TODO: Change to evaluate results of measure reports
            var exportResult = ExportResult.Accepted();
            exportResult.SetContentLocationHeader(_urlResolver, OperationsConstants.Export, response.JobId);
            return Ok("Routed Successfully");
        }
    }
}
