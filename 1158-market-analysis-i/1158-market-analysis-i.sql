/* Write your T-SQL query statement below */
select
    Users.user_id as buyer_id,
    Users.join_date,
    count(CASE WHEN YEAR(Orders.order_date) = 2019 THEN 1 ELSE NULL END) as orders_in_2019
from
    Users
    left join Orders on Users.user_id = Orders.buyer_id
group by
    Users.user_id,
    Users.join_date
order by
    Users.user_id