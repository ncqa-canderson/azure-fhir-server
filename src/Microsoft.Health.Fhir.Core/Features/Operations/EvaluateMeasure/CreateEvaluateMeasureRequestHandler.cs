// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EnsureThat;
using Hl7.Fhir.Rest;
using MediatR;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Health.Core.Features.Context;
using Microsoft.Health.Core.Features.Security;
using Microsoft.Health.Core.Features.Security.Authorization;
using Microsoft.Health.Fhir.Core.Configs;
using Microsoft.Health.Fhir.Core.Exceptions;
using Microsoft.Health.Fhir.Core.Extensions;
using Microsoft.Health.Fhir.Core.Features.Context;
using Microsoft.Health.Fhir.Core.Features.Operations.EvaluateMeasure.Models;
using Microsoft.Health.Fhir.Core.Messages.EvaluateMeasure;

namespace Microsoft.Health.Fhir.Core.Features.Operations.EvaluateMeasure
{
    public class CreateEvaluateMeasureRequestHandler : IRequestHandler<CreateEvaluateMeasureRequest, CreateEvaluateMeasureResponse>
    {
        private readonly IFhirOperationDataStore _fhirOperationDataStore;
        private readonly RequestContextAccessor<IFhirRequestContext> _contextAccessor;
        private readonly ILogger<CreateEvaluateMeasureRequestHandler> _logger;

        public CreateEvaluateMeasureRequestHandler(
            IFhirOperationDataStore fhirOp,
            RequestContextAccessor<IFhirRequestContext> fhirRequestContext,
            ILogger<CreateEvaluateMeasureRequestHandler> logger)
        {
            EnsureArg.IsNotNull(fhirOp, nameof(fhirOp));
            EnsureArg.IsNotNull(fhirRequestContext, nameof(fhirRequestContext));
            EnsureArg.IsNotNull(logger, nameof(logger));

            _fhirOperationDataStore = fhirOp;
            _contextAccessor = fhirRequestContext;
            _logger = logger;
        }

        public async Task<CreateEvaluateMeasureResponse> Handle(CreateEvaluateMeasureRequest request, CancellationToken cancellationToken)
        {
            EnsureArg.IsNotNull(request, nameof(request));

            var jobRecord = new Models.EvaluateMeasureJobRecord(
                requestUri: request.RequestUri,
                measureId: request.MeasureId,
                subject: request.Subject);

            var outcome = await _fhirOperationDataStore.CreateEvaluateMeasureJobAsync(jobRecord, cancellationToken);

            return new CreateEvaluateMeasureResponse(outcome.JobRecord.Id);
        }
    }
}
