// <auto-generated />
namespace Microsoft.AspNetCore.Tooling.Razor
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Tooling.Razor.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// '{0}'s cannot be resolved with protocol '{1}'. Protocol not supported.
        /// </summary>
        internal static string InvalidProtocolValue
        {
            get { return GetString("InvalidProtocolValue"); }
        }

        /// <summary>
        /// '{0}'s cannot be resolved with protocol '{1}'. Protocol not supported.
        /// </summary>
        internal static string FormatInvalidProtocolValue(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidProtocolValue"), p0, p1);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
