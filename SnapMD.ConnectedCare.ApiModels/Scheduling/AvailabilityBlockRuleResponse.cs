﻿using System;

namespace SnapMD.ConnectedCare.ApiModels.Scheduling
{
    public class AvailabilityBlockRuleResponse : AvailabilityBlockRuleRequest
    {
        public int Id { get; set; }

        public DateTime FromDate { get; set; }
    }
}
