// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EnsureThat;
using Hl7.Cql.ValueSets;
using MediatR;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Health.Core.Features.Context;
using Microsoft.Health.Extensions.DependencyInjection;
using Microsoft.Health.Fhir.Core.Features.Context;
using Microsoft.Health.Fhir.Core.Features.Operations.EvaluateMeasure.Models;
using Microsoft.Health.Fhir.Core.Features.Operations.Export;
using Microsoft.Health.Fhir.Core.Features.Persistence;

namespace Microsoft.Health.Fhir.Core.Features.Operations.EvaluateMeasure
{
    public class EvaluateMeasureTask : IEvaluateMeasureTask
    {
        private readonly Func<IScoped<IFhirOperationDataStore>> _fhirOperationDataStoreFactory;
        private readonly IResourceDeserializer _resourceDeserializer;
        private readonly IMediator _mediator;
        private readonly RequestContextAccessor<IFhirRequestContext> _contextAccessor;
        private readonly ILogger _logger;

        private EvaluateMeasureJobRecord _evaluateMeasureJobRecord;
        private WeakETag _weakETag;

        public EvaluateMeasureTask(
            Func<IScoped<IFhirOperationDataStore>> fhirOperationDataStoreFactory,
            IResourceDeserializer resourceDeserializer,
            IMediator mediator,
            RequestContextAccessor<IFhirRequestContext> contextAccessor,
            ILogger<EvaluateMeasureTask> logger)
        {
            EnsureArg.IsNotNull(fhirOperationDataStoreFactory, nameof(fhirOperationDataStoreFactory));
            EnsureArg.IsNotNull(resourceDeserializer, nameof(resourceDeserializer));
            EnsureArg.IsNotNull(mediator, nameof(mediator));
            EnsureArg.IsNotNull(contextAccessor, nameof(contextAccessor));
            EnsureArg.IsNotNull(logger, nameof(logger));

            _fhirOperationDataStoreFactory = fhirOperationDataStoreFactory;
            _resourceDeserializer = resourceDeserializer;
            _mediator = mediator;
            _contextAccessor = contextAccessor;
            _logger = logger;

            UpdateEvaluateMeasureJob = UpdateEvaluateMeasureJobInternal;
        }

        public Func<EvaluateMeasureJobRecord, WeakETag, CancellationToken, Task<EvaluateMeasureJobOutcome>> UpdateEvaluateMeasureJob
        {
            get; set;
        }

        public Task ExecuteAsync(EvaluateMeasureJobRecord evaluateMeasureJobRecord, WeakETag weakETag, CancellationToken cancellationToken)
        {
            EnsureArg.IsNotNull(evaluateMeasureJobRecord, nameof(evaluateMeasureJobRecord));

            _evaluateMeasureJobRecord = evaluateMeasureJobRecord;
            _weakETag = weakETag;

            var existingFhirRequestContext = _contextAccessor?.RequestContext;

            throw new NotImplementedException();
        }

        private async Task<EvaluateMeasureJobOutcome> UpdateEvaluateMeasureJobInternal(EvaluateMeasureJobRecord jobRecord, WeakETag eTag, CancellationToken cancellationToken)
        {
            EnsureArg.IsNotNull(jobRecord, nameof(jobRecord));
            EnsureArg.IsNotNull(eTag, nameof(eTag));

            using var fhirOperationDataStore = _fhirOperationDataStoreFactory();

            return await fhirOperationDataStore.Value.UpdateEvaluateMeasureJobAsync(jobRecord, eTag, cancellationToken);
        }
    }
}
