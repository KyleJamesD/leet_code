/* Write your PL/SQL query statement below */
SELECT 
    user_id as "USER_ID",
    CONCAT(UPPER(substr(name, 1, 1)),LOWER(substr(name, 2, LENGTH(name)-1))) as "name" 
FROM Users  
ORDER BY user_id ASC;




-- 1667. Fix Names in a Table
-- Solved
-- Easy
-- Topics
-- Companies
-- SQL Schema
-- Pandas Schema

-- Table: Users

-- +----------------+---------+
-- | Column Name    | Type    |
-- +----------------+---------+
-- | user_id        | int     |
-- | name           | varchar |
-- +----------------+---------+
-- user_id is the primary key (column with unique values) for this table.
-- This table contains the ID and the name of the user. The name consists of only lowercase and uppercase characters.

 

-- Write a solution to fix the names so that only the first character is uppercase and the rest are lowercase.

-- Return the result table ordered by user_id.

-- The result format is in the following example.

 

-- Example 1:

-- Input: 
-- Users table:
-- +---------+-------+
-- | user_id | name  |
-- +---------+-------+
-- | 1       | aLice |
-- | 2       | bOB   |
-- +---------+-------+
-- Output: 
-- +---------+-------+
-- | user_id | name  |
-- +---------+-------+
-- | 1       | Alice |
-- | 2       | Bob   |
-- +---------+-------+

