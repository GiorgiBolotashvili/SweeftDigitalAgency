select distinct t.FirstName, t.LastName
from Teacher t
inner join Class_Subject cs on cs.SubjectName = t.SubjectName
inner join Pupil p on p.Class = cs.Class
where p.FirstName = 'Giorgi'