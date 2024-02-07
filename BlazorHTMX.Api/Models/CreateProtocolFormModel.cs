﻿namespace BlazorHTMX.Api.Models
{
    public record CreateProtocolFormModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IEnumerable<ProfileModel> Profiles { get; set; } = Enumerable.Empty<ProfileModel>();
    }
}
