﻿using System.Collections.Generic;
using Stories.Meta.Relationships;
using Stories.Models;

namespace Stories.Meta
{
    public class StoryData : IModelData
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Data { get; set; }
        public ProjectInStoryData Project { get; set; }
        public IEnumerable<BusinessRulesInStoryData> BusinessRules { get; set; }
    }
}