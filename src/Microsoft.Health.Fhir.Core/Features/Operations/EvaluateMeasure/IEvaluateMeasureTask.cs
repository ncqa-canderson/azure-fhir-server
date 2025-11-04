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
using Microsoft.Health.Fhir.Core.Features.Operations.EvaluateMeasure.Models;
using Microsoft.Health.Fhir.Core.Features.Persistence;

namespace Microsoft.Health.Fhir.Core.Features.Operations.EvaluateMeasure
{
    public interface IEvaluateMeasureTask
    {
        Func<EvaluateMeasureJobRecord, WeakETag, CancellationToken, Task<EvaluateMeasureJobOutcome>> UpdateEvaluateMeasureJob
        {
            get; set;
        }

        Task ExecuteAsync(EvaluateMeasureJobRecord evaluateMeasureJobRecord, WeakETag weakETag, CancellationToken cancellationToken);
    }
}
