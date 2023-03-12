/* Write your T-SQL query statement below */
SELECT user_id,                                                  CONCAT(subStr1, subStr2) AS name                                 FROM (SELECT user_id, UPPER(substring(name, 1, 1)) As subStr1 ,  substring(name, 2, (len(name)-1)) As subStr2
FROM (SELECT user_id, LOWER(name) as name FROM users) As T1
) As T2

ORDER BY user_id;