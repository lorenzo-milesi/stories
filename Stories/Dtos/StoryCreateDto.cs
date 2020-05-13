﻿using System.ComponentModel.DataAnnotations;

namespace Stories.Dtos
{
    public class StoryCreateDto
    {
        [Required]
        [MinLength(3)]
        [MaxLength(250)]
        public string Title { get; set; }

        public string Description { get; set; }
        public string Data { get; set; }

        [Required]
        public int ProjectId { get; set; }
    }
}