CREATE PROCEDURE [dbo].[spProjects_Update]
	@Id int,
	@Name nvarchar(50),
	@Description nvarchar(50),
	@ProjectSize nvarchar(50)
AS
begin
	update dbo.[Projects]
	set Name = @Name, Description = @Description, ProjectSize = @ProjectSize
	where Id= @Id

end
