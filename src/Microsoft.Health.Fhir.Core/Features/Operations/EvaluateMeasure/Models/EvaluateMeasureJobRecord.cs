// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using EnsureThat;
using Microsoft.Health.Core;
using Microsoft.Health.Fhir.Core.Extensions;
using Microsoft.Health.Fhir.Core.Models;
using Microsoft.Health.JobManagement;
using Newtonsoft.Json;

namespace Microsoft.Health.Fhir.Core.Features.Operations.EvaluateMeasure.Models
{
    public class EvaluateMeasureJobRecord : JobRecord, IJobData
    {
        public EvaluateMeasureJobRecord(
            Uri requestUri,
            string measureId,
            string subject,
            PartialDateTime since = null,
            PartialDateTime till = null,
            string startSurrogateId = null,
            string endSurrogateId = null,
            string globalStartSurrogateId = null,
            string globalEndSurrogateId = null,
            bool isParallel = true,
            int schemaVersion = 2,
            int typeId = (int)JobType.EvaluateMeasureOrchestrator)
        {
            EnsureArg.IsNotNull(requestUri, nameof(requestUri));
            EnsureArg.IsNotNullOrWhiteSpace(measureId, nameof(measureId));
            EnsureArg.IsNotNullOrWhiteSpace(subject, nameof(subject));

            RequestUri = requestUri;
            MeasureId = measureId;
            Subject = subject;
            TypeId = typeId;

            // Default values
            SchemaVersion = schemaVersion;
            Id = Guid.NewGuid().ToString();
            Status = OperationStatus.Queued;

            QueuedTime = Clock.UtcNow;
            Till = till ?? new PartialDateTime(Clock.UtcNow);
            StartSurrogateId = startSurrogateId;
            EndSurrogateId = endSurrogateId;
            GlobalStartSurrogateId = globalStartSurrogateId;
            GlobalEndSurrogateId = globalEndSurrogateId;
        }

        [JsonProperty(JobRecordProperties.TypeId)]
        public int TypeId { get; internal set; }

        [JsonProperty(JobRecordProperties.RequestUri)]
        public Uri RequestUri { get; internal set; }

        [JsonProperty(JobRecordProperties.Subject)]
        public string Subject { get; internal set; }

        [JsonProperty(JobRecordProperties.MeasureId)]
        public string MeasureId { get; internal set; }

        [JsonProperty(JobRecordProperties.Till)]
        public PartialDateTime Till { get; private set; }

        [JsonProperty(JobRecordProperties.Issues)]
        public IList<OperationOutcomeIssue> Issues { get; private set; } = new List<OperationOutcomeIssue>();

        [JsonProperty(JobRecordProperties.StartSurrogateId)]
        public string StartSurrogateId { get; private set; }

        [JsonProperty(JobRecordProperties.EndSurrogateId)]
        public string EndSurrogateId { get; private set; }

        [JsonProperty(JobRecordProperties.GlobalEndSurrogateId)]
        public string GlobalEndSurrogateId { get; private set; }

        [JsonProperty(JobRecordProperties.GlobalStartSurrogateId)]
        public string GlobalStartSurrogateId { get; private set; }

        [JsonProperty(JobRecordProperties.Progress)]
        public int Progress { get; set; }

        internal EvaluateMeasureJobRecord Clone()
        {
            return (EvaluateMeasureJobRecord)MemberwiseClone();
        }
    }
}
