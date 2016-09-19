using Nancy;
namespace HelloNancy
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get("/", args => "Hello Nancy!");

            Post("/template", args => 
            {
                return Response.AsRedirect("/");
            });

            Get("/{value:name}", args => "Hello " + args.name + "!");

        }
    }
}