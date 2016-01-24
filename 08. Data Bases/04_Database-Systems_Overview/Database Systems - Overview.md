## Database Systems - Overview
### _Homework_

1.  What database models do you know?
    - Relationsl model : It is the most poppular database model. I defines a database as a collection of related tables which contain all data. 
    - Network model : Also called graph model. It defines objects that a linked togeher with a many-to-many relation.
    - Hierarchical Model : Consisnts of data segments that have a parent-child relationship
2.  Which are the main functions performed by a Relational Database Management System (RDBMS)?
    - Creating and deleteing tables and relations between them
    - Adding, changing, deleting, searching and retrieving of data stored in the tables
    - Supports the SQL language
    - Transaction management
3.  Define what is "table" in database terms.
    - A table is a collection of related data held in a structured format within a database. It consists of fields (columns), and rows.
4.  Explain the difference between a primary and a foreign key.
    - Primary key is the primary identifier of a record in a database table
    - Foreign key is a field in a table that serves as an identifier to records in another table, foreign keys serve as a relation between tables.
5.  Explain the different kinds of relationships between tables in relational databases.
    - Many-to-Many - Multiple recors from one table can be related to multiple records in another table
    - One-to-Many - One record from one table can be related to many records in another table
    - One-to-One - One record from one table can be related to only one records from another table
6.  When is a certain database schema normalized?
    - A normalized databse has no repeating data
    - Every table has it's own primary key and is linked to other tables using foreign keys
7.  What are database integrity constraints and when are they used?
- Integrity constraints are a set of rules that are enforcesd on the data. The database engine ensures those rules aren't broken. 
    - Primary key constraint - Ensures that the primary key of a table has unique value for each table row
    - Unique key constraint - Ensures that all values in a certain column (or a group of columns) are unique
    - Foreign key constraint - Ensures that the value in given column is a key from another table
    - Check constraint - Ensures that values in a certain column meet some predefined condition
8.  Point out the pros and cons of using indexes in a database.
- Pros
    - Indexes speed up searching of values in a certain column or group of columns
- Cons
    - Indexes require disc space and require time for updating when adding or changig data
- Since data is searched way more frequently than changed, the pros of the index greatly outweigh the cons 
9.  What's the main purpose of the SQL language?
    - The SQL languange's main purpose is to allow us to communicate with the database - issue commands, change setting, add indexes, constraints and so on.
10.  What are transactions used for?
  - Transtactions are used when sensitive data is manipulated by more than one entity at the same time. The data is locked for manipulation to everyone except for the first who tried to manipulate it. For example bank transtactions that transfer money to and from different accounts, when more than one person is trying to withdraw money from the same account at ste same time.
11.  What is a NoSQL database?
     - A NoSQL database does not use relations. It is only document based. 
12.  Explain the classical non-relational data models.
     - A non-relational database is a database that does not incorporate the table/key model that relational database management systems (RDBMS) promote. These kinds of databases require data manipulation techniques and processes designed to provide solutions to big data problems that big companies face. 
13.  Give few examples of NoSQL databases and their pros and cons.
     - They are performance oriented, but the data is not consistent.
     - Very scalable
     - A good example is a JSON and XML data storage