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
using MediatR;
using Microsoft.Health.Fhir.Core.Messages.EvaluateMeasure;

namespace Microsoft.Health.Fhir.Core.Extensions
{
    public static class EvaluateMeasureMediatorExtensions
    {
        public static async Task<CreateEvaluateMeasureResponse> EvaluateMeasureAsync(
            this IMediator mediator,
            Uri requestUri,
            string measureId,
            string subject,
            CancellationToken cancellationToken)
        {
            EnsureArg.IsNotNull(mediator, nameof(mediator));
            EnsureArg.IsNotNull(requestUri, nameof(requestUri));

            var request = new CreateEvaluateMeasureRequest(
                requestUri: requestUri,
                measureId: measureId,
                subject: subject);

            CreateEvaluateMeasureResponse response = await mediator.Send(request, cancellationToken);
            return response;
        }
    }
}
