SET FOREIGN_KEY_CHECKS = 0;
truncate table tblTask;
truncate table tblEmployee;
SET FOREIGN_KEY_CHECKS = 1;


insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName)
values ("001001","Trinh", "Hoang Trung");

insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName)
values ("001002","Dang", "Xuan Khanh");

insert into tblTask (TaskCode,TaskName,Description,Assignee,Reporter,Status,Priority,TaskType) 
values ("KMF-1","Design software architecture","Design software architecture",1,2,0,0,0); 

select tblTask.* ,tblEmployee.*  from tblTask 
inner join tblEmployee where (tblTask.Assignee = tblemployee.ID);

select t.*, CONCAT_WS(' ',e1.EmployeeFirstName, e1.EmployeeLastName) as AssigneeName, 
CONCAT_WS(" ",e2.EmployeeFirstName, e2.EmployeeLastName) as ReporterName
from tbltask t, tblemployee e1, tblemployee e2 where t.Assignee = e1.ID and t.Reporter = e2.ID; 

  <iframe src="https://www.google.com/recaptcha/api2/anchor?ar=1&k=6Lc2_RsUAAAAAAYBSd4rxsgeQz7whuL9COCsHeET&co=aHR0cHM6Ly9hcHAuaHVic3BvdC5jb206NDQz&hl=vi&v=pRiAUlKgZOMcFLsfzZTeGtOA&size=invisible&badge=inline&cb=1l5d2fmgg5c5" frameborder="0"></iframe>
