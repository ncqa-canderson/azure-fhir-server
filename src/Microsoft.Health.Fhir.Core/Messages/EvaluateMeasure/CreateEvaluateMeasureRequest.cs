// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnsureThat;
using MediatR;

namespace Microsoft.Health.Fhir.Core.Messages.EvaluateMeasure
{
    public class CreateEvaluateMeasureRequest : IRequest<CreateEvaluateMeasureResponse>
    {
        public CreateEvaluateMeasureRequest(Uri requestUri, string measureId, string subject)
        {
            EnsureArg.IsNotNull(requestUri, nameof(requestUri));
            EnsureArg.IsNotNull(measureId, nameof(measureId));
            EnsureArg.IsNotNull(subject, nameof(subject));

            RequestUri = requestUri;
            MeasureId = measureId;
            Subject = subject;
        }

        public Uri RequestUri { get; }

        public string MeasureId { get; }

        public string Subject { get; }
    }
}
