/* Write your T-SQL query statement below */
  UPDATE salary
  SET sex = 
    CASE sex 
        when 'f' then 'm' 
        when 'm' then 'f' 
        else sex
    END