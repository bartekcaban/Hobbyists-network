﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hobbyist_Network.Application.DTOs.Event
{
    public class EventDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Localization { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid OrganiserId { get; set; }
        public string CategoryName { get; set; }
        public Guid CategoryId { get; set; }
    }
}
