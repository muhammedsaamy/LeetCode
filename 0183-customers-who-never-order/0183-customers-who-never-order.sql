/* Write your T-SQL query statement below */
select name as customers from customers c
left join orders o
on c.id = o.customerId
where o.customerId is null