using OrchardCore.ResourceManagement;

namespace OrchardCore.Themes.TheCleanBlogTheme
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineStyle("TheTheme-bootstrap-oc")
                .SetUrl("~/TheTheme/css/bootstrap-oc.min.css", "~/TheTheme/css/bootstrap-oc.css")
                .SetVersion("1.0.0");
				
        }
    }
}
