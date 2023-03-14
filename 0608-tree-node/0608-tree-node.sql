/* Write your T-SQL query statement below */
select id,
case
when p_id is null then 'Root'
when exists (select p_id from tree tr where t.id=tr.p_id) then 'Inner'
else 'Leaf'
end 'type'
from Tree t
order by t.id asc