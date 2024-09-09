CREATE PROCEDURE [dbo].[spProjects_Insert]
	@Name nvarchar(50),
	@Description nvarchar(50),
	@ProjectSize nvarchar(50)
AS
begin
	insert into dbo.[Projects] (Name, Description, ProjectSize)
	values (@Name, @Description, @ProjectSize);
end
