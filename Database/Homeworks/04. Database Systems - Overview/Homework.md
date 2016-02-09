### What database models do you know?
>
|Common models|Other models|
|-------------|------------|
|<ul><li>Flat</li><li>Hierarchical</li><li>Dimensional</li><li>Network</li><li>Relational</li><li>Entity–relationship (Enhanced)</li><li>Graph</li><li>Object-oriented</li><li>Entity–attribute–value.</li></ul>|<ul><li>Associative</li><li>Multidimensional</li><li>Array</li><li>Semantic</li><li>Star schema</li><li>XML database</li></ul>|


###  Which are the main functions performed by a Relational Database Management System (RDBMS)?
> There are several functions that a DBMS performs to ensure data integrity and consistency of data in the database. The ten functions in the DBMS are: data dictionary management, data storage management, data transformation and presentation, security management, multiuser access control, backup and recovery management, data integrity management, database access languages and application programming interfaces, database communication interfaces, and transaction management.

##  Define what is "table" in database terms.
> <p>A table is a collection of related data held in a structured format within a database. It consists of fields (columns), and rows.</p>
<p>In relational databases and flat file databases, a table is a set of data elements (values) using a model of vertical columns (identifiable by name) and horizontal rows, the cell being the unit where a row and column intersect. A table has a specified number of columns, but can have any number of rows. Each row is identified by one or more values appearing in a particular column subset. The columns subset which uniquely identifies a row is called the primary key.</p>

##  Explain the difference between a primary and a foreign key.
> 
|Primary Key|Foreign Key|
|-----------|-----------|
|Primary key uniquely identify a record in the table.|Foreign key is a field in the table that is primary key in another table.|
|Primary Key can't accept null values.| Foreign key can accept multiple null value.|
|By default, Primary key is clustered index and data in the database table is physically organized in the sequence of clustered index.| Foreign key do not automatically create an index, clustered or non-clustered. You can manually create an index on foreign key.
|We can have only one Primary key in a table.|We can have more than one foreign key in a table.|

##  Explain the different kinds of relationships between tables in relational databases.
> 
<ul><li>Relationship one-to-many (or many-to-one)<ul><li>A single record in the first table has many corresponding records in the second table</li></ul></li><li>Relationship many-to-many<ul><li>Records in the first table have many corresponding records in the second one and vice versa</li></ul></li><li>Relationship one-to-one<ul><li>A single record in a table corresponds to a single record in the other table</li><li>Used to model inheritance between tables</li></ul></li></ul>


##  When is a certain database schema normalized?
> Database normalization (or normalisation) is the process of organizing the columns (attributes) and tables (relations) of a relational database to minimize data redundancy.

- What are the advantages of normalized databases?

> Normalization involves decomposing a table into less redundant (and smaller) tables without losing information; defining foreign keys in the old table referencing the primary keys of the new ones. The objective is to isolate data so that additions, deletions, and modifications of an attribute can be made in just one table and then propagated through the rest of the database using the defined foreign keys.

##  What are database integrity constraints and when are they used?
> 
Integrity constraints provide a mechanism for ensuring that data conforms to guidelines specified by the database administrator. The most common types of constraints include:
 - UNIQUE constraints
To ensure that a given column is unique
 - NOT NULL constraints
To ensure that no null values are allowed
 - FOREIGN KEY constraints
To ensure that two keys share a primary key to foreign key relationship
>
Constraints can be used for these purposes in a data warehouse:
 - Data cleanliness
 - Constraints verify that the data in the data warehouse conforms to a basic level of data consistency and correctness, preventing the introduction of dirty data.
 - Query optimization.

##  Point out the pros and cons of using indexes in a database.
>
The indexing increases the disk space usage and reduces the performance of adding, deleting, and updating, but in most cases the benefit of indices for data retrieval greatly exceeds the disadvantages.
*Pros:*
  * Fast searching
  * Fast sorting
*Cons:*
  * Slow insert
  * Slow update

##  What's the main purpose of the SQL language?
> SQL (Structured Query Language) is a special-purpose programming language designed for managing data held in a relational database management system (RDBMS), or for stream processing in a relational data stream management system (RDSMS).
>
The main purpose of SQL is to provide a Structured way by which one can Query information in database using a standard Language.

##  What are transactions used for?
> A transaction symbolizes a unit of work performed within a database management system (or similar system) against a database, and treated in a coherent and reliable way independent of other transactions. A transaction generally represents any change in database. Transactions in a database environment have two main purposes:
>
To provide reliable units of work that allow correct recovery from failures and keep a database consistent even in cases of system failure, when execution stops (completely or partially) and many operations upon a database remain uncompleted, with unclear status.
To provide isolation between programs accessing a database concurrently. If this isolation is not provided, the programs' outcomes are possibly erroneous.
A database transaction, by definition, must be atomic, consistent, isolated and durable. Database practitioners often refer to these properties of database transactions using the acronym ACID.
>
Transactions provide an "all-or-nothing" proposition, stating that each work-unit performed in a database must either complete in its entirety or have no effect whatsoever. Further, the system must isolate each transaction from other transactions, results must conform to existing constraints in the database, and transactions that complete successfully must get written to durable storage.

- Give an example.
>
```sql
USE pubs

DECLARE @intErrorCode INT

BEGIN TRAN
    UPDATE Authors
    SET Phone = '415 354-9866'
    WHERE au_id = '724-80-9391'

    SELECT @intErrorCode = @@ERROR
    IF (@intErrorCode <> 0) GOTO PROBLEM

    UPDATE Publishers
    SET city = 'Calcutta', country = 'India'
    WHERE pub_id = '9999'

    SELECT @intErrorCode = @@ERROR
    IF (@intErrorCode <> 0) GOTO PROBLEM
COMMIT TRAN

PROBLEM:
IF (@intErrorCode <> 0) BEGIN
PRINT 'Unexpected error occurred!'
    ROLLBACK TRAN
END
```
##  What is a NoSQL database?
> A NoSQL (originally referring to "non SQL" or "non relational") database provides a mechanism for storage and retrieval of data that is modeled in means other than the tabular relations used in relational databases.
>
*	Use `document-based` model (non-relational)
*	Schema-free document storage
	*	Still support CRUD operations
		*	Create, Read, Update, Delete
	*	Still support indexing and querying
	*	Still supports concurrency  and transactions
*	Highly optimized for append / retrieve
*	Great performance and scalability
*	NoSQL == “No SQL” or “Not Only SQL”?

##  Give few examples of NoSQL databases and their pros and cons.
> 
There have been various approaches to classify NoSQL databases, each with different categories and subcategories, some of which overlap. A basic classification based on data model, with examples:
>
*	Column: Accumulo, Cassandra, Druid, HBase, Vertica
*	Document: Clusterpoint, Apache CouchDB, Couchbase, DocumentDB, HyperDex, Lotus Notes, MarkLogic, MongoDB, OrientDB, Qizx
*	Key-value: CouchDB, Oracle NoSQL Database, Dynamo, FoundationDB, HyperDex, MemcacheDB, Redis, Riak, FairCom c-treeACE, Aerospike, OrientDB, MUMPS
*	Graph: Allegro, Neo4J, InfiniteGraph, OrientDB, Virtuoso, Stardog
*	Multi-model: OrientDB, FoundationDB, ArangoDB, Alchemy Database, CortexDB
>
**Pros:**
>
*	It's Open Source - Open source products provide developers with some great benefits, notably their no-cost status. Other benefits: open-source software tends to be more reliable, secure, and faster to deploy than proprietary alternatives.
*	Elastic Scaling - NoSQL replaces the old 'scale up' mantra of database managers with a new one: 'scale out.' Instead of adding bigger servers to handle more data load, a NoSQL database allows a company to distribute the load across multiple hosts as the load increases.
*	Different NoSQL DBs for Different Projects - MongoDB and Redis are good choices for storing frequently-written, rarely read statistical data, such as a web hit counter. Hadoop, a freeform, distributed DB does a good job of storing Big Data such as weather stats or business analytics work. Memcache, a transient DB, excels at storing web sessions, locks, and short-term stats). Cassandra and Riak (automatically clustered, redundant stores) perform well in environments with high availability apps, when maximum uptime is vital.
*	NoSQL’s Impressive Implementations - Companies such as Amazon, the BBC, Facebook and Google rely on NoSQL DBs.
*	NoSQL Flies High in the Cloud - NoSQL and the cloud are a natural fit. Today’s servers are inexpensive and can easily be scaled up on demand using a service such as Amazon EC2. Like all cloud technology, EC2 is based on virtualization. The weak link of virtualization is I/O performance, with memory and CPU being the strong links. NoSQL databases mostly use memory over disk as the primary write location – thereby preventing inconsistent I/O performance. And since NoSQL datastores typically leverage horizontal scalability via partitioning, they are able to take advantage of the cloud’s elastic provisioning.
>
**Cons:**
>
*	Open Source can Mean Spotty Support for Enterprises
*	Not Mature Enough for Enterprises
*	Business Intelligence Limitations
*	Lack of Expertise
*	Compatibility Issues