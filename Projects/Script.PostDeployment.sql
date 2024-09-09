
if not exists (select 1 from dbo.Projects)
begin 
	insert into dbo.[Projects] (Name, Description, ProjectSize)
	values ('Test Project', 'Testing the input', 'Small'),
	('DemoWork', 'Another sample text', 'Large');

end

