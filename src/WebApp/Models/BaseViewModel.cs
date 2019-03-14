using System.Collections.Generic;

namespace WebApp.Models
{
    public abstract class BaseViewModel
    {
        protected abstract Dictionary<string, string> Labels { get; }

        public string UserComment { get; set; }

        public string GetLabel(string propName)
        {
            if (!Labels.TryGetValue(propName, out var label))
                throw new KeyNotFoundException($"Label not found for property name: {propName}");

            return label;
        }
    }

    public sealed class UserViewModel : BaseViewModel
    {
        protected override Dictionary<string, string> Labels => new Dictionary<string, string>
        {
            { nameof(UserComment), "User label" }
        };
    }

    public sealed class AdminViewModel : BaseViewModel
    {
        protected override Dictionary<string, string> Labels => new Dictionary<string, string>
        {
            { nameof(UserComment), "Admin label" }
        };
    }
}
