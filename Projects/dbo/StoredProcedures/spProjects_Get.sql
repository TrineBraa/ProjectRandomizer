CREATE PROCEDURE [dbo].[spProjects_Get]
	@Id int
AS
begin
select Id, Name, Description, ProjectSize
	from dbo.[Projects]
	where Id = @Id;
end
