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
using Microsoft.Health.Fhir.Core.Features.Persistence;

namespace Microsoft.Health.Fhir.Core.Features.Operations.EvaluateMeasure.Models
{
    public class EvaluateMeasureJobOutcome
    {
        public EvaluateMeasureJobOutcome(EvaluateMeasureJobRecord jobRecord, WeakETag eTag)
        {
            EnsureArg.IsNotNull(jobRecord, nameof(jobRecord));
            EnsureArg.IsNotNull(eTag, nameof(eTag));

            JobRecord = jobRecord;
            ETag = eTag;
        }

        /// <summary>
        /// Metadata for the evluate measure job.
        /// </summary>
        public EvaluateMeasureJobRecord JobRecord { get; }

        /// <summary>
        /// Represents the version of the document in the datastore. Used to resolve conflicts.
        /// </summary>
        public WeakETag ETag { get; }
    }
}
