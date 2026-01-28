import Database from 'better-sqlite3';

const db = Database('data/db.sql');

db.prepare(
    `CREATE TABLE IF NOT EXISTS fours (id INTEGER PRIMARY KEY AUTOINCREMENT, numbers TEXT UNIQUE)`,
).run();

export default db;
