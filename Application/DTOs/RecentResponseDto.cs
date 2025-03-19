
using System;

namespace SurveyApp.Application.DTOs
{
    public class RecentResponseDto
    {
        public Guid Id { get; set; }
        public Guid SurveyId { get; set; }
        public string SurveyTitle { get; set; }
        public string RespondentName { get; set; }
        public DateTime SubmittedAt { get; set; }
    }
}
