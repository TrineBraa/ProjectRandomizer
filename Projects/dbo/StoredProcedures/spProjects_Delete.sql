CREATE PROCEDURE [dbo].[spProjects_Delete]
	@id int
AS
begin
	delete
	from dbo.[Projects]
	where Id = @Id
end
