using Feedback.Infrastructure.Data;
using Feedback.Core.Interfaces.DomainServices;
using Feedback.Core.Services;
using Feedback.Infrastructure.Interfaces.Repositories;
using Feedback.Web.Types;
using Microsoft.EntityFrameworkCore;

const string policyName = "AllowOrigin";
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policyName,
        builder =>
        {
            builder
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});


//DBContext
builder.Services.AddDbContext<ReviewContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbContext"));
});

//Build services
builder.Services.AddScoped<IReviewService, ReviewService>();
builder.Services.AddScoped<IOrderService, OrderService>();
 
//Build repositories
builder.Services.AddScoped(typeof(IReadRepository<>), typeof(EfRepository<>));
builder.Services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
// JWT Configuration

//graphql
builder.Services
    .AddGraphQLServer()
    .ModifyRequestOptions(opt => opt.IncludeExceptionDetails = true)
    .AddQueryType<QueryType>()
    .AddMutationType<MutationType>();

          
var app = builder.Build();
app.UseStaticFiles();

app.UseCors(policyName);
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapGraphQL("/graphql");


app.Run();