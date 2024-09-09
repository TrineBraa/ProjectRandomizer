CREATE PROCEDURE [dbo].[spProjects_GetAll]

AS
begin
	select Id, Name, Description, ProjectSize
	from dbo.[Projects];
end
