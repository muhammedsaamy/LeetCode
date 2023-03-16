/* Write your T-SQL query statement below */
select
    activity_date [day],
    count(distinct user_id) [active_users]
from
    Activity
where
    DATEDIFF(day, activity_date, '2019-07-27') < 30
    and DATEDIFF(day, activity_date, '2019-07-27') > 0
group by
    activity_date
order by
    activity_date