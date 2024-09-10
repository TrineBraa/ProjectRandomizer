namespace ProjectRandomizer;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        //All of the API Endpoint mapping
        app.MapGet("/Project", GetAllProjects);
        app.MapGet("/Project/{id}", GetProject);
        app.MapPost("/Project", InsertProject);
        app.MapPut("/Project", UpdateProject);
        app.MapDelete("/Project", DeleteProject);
    }

    private static async Task<IResult> GetAllProjects(IProjectData project)
    {
        try
        {
            return Results.Ok(await project.GetAllProjects()); //Returns all projects in the db.
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetProject(int id, IProjectData project)
    {
        try
        {
            var results = await project.GetProject(id);
            if (results == null) return Results.NotFound(); //If it gets null in return it throws this
            return Results.Ok(results); //Otherwise return ok with the result.
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message); 
        }
    }

    private static async Task<IResult> InsertProject(ProjectModel model, IProjectData project)
    {
        try
        {
            await project.InsertProject(model);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }


    private static async Task<IResult> UpdateProject(ProjectModel model, IProjectData project)
    {
        try
        {
            await project.UpdateProject(model);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteProject(int id, IProjectData project)
    {
        try
        {
            await project.DeleteProject(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }


}
