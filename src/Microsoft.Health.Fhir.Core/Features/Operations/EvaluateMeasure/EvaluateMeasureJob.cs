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
using Microsoft.Build.Framework;
using Microsoft.Extensions.Logging;
using Microsoft.Health.JobManagement;

namespace Microsoft.Health.Fhir.Core.Features.Operations.EvaluateMeasure
{
    [JobTypeId((int)JobType.EvaluateMeasureProcessing)]
    public class EvaluateMeasureJob : IJob
    {
        private readonly ILogger<EvaluateMeasureJob> _logger;

        public EvaluateMeasureJob(
            ILogger<EvaluateMeasureJob> logger)
        {
            _logger = EnsureArg.IsNotNull(logger, nameof(logger));
        }

        public Task<string> ExecuteAsync(JobInfo jobInfo, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
