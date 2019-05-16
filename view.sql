select dd.Expr2,dd.DESCR,ff.Expr1
from(SELECT     MAX(dbo._1SCONST.DATE) AS Expr2, dbo.SC2.DESCR, dbo._1SCONST.OBJID
FROM         dbo._1SCONST INNER JOIN
                      dbo.SC2 ON dbo._1SCONST.OBJID = dbo.SC2.ID 
GROUP BY dbo.SC2.DESCR, dbo._1SCONST.ID, dbo._1SCONST.OBJID
HAVING      (dbo._1SCONST.ID = 1498)
) dd
inner join (SELECT        MAX(dbo._1SCONST.DATE) AS Expr2, dbo.SC2.DESCR, dbo._1SCONST.OBJID, dbo._1SCONST.VALUE, dbo.SC23.DESCR AS Expr1
FROM            dbo._1SCONST INNER JOIN
                         dbo.SC2 ON dbo._1SCONST.OBJID = dbo.SC2.ID INNER JOIN
                         dbo.SC23 ON dbo._1SCONST.VALUE = dbo.SC23.ID
GROUP BY dbo.SC2.DESCR, dbo._1SCONST.ID, dbo._1SCONST.OBJID, dbo._1SCONST.VALUE, dbo.SC23.DESCR
HAVING        (dbo._1SCONST.ID = 1498)) ff
on  dd.OBJID=ff.OBJID and dd.DESCR=ff.DESCR and dd.Expr2=ff.Expr2
order by dd.DESCR