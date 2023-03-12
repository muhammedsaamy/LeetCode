/* Write your T-SQL query statement below */
select sell_date , count(distinct product) as num_sold, 
string_agg(product,',') within group (order by product) as products
from (select distinct sell_date,product from Activities) as newTable
group by sell_date