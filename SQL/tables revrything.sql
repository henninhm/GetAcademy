CREATE TABLE albums (
    id INT PRIMARY KEY,
    title VARCHAR(50) NOT NULL,
    artist_id int NOT NULL,
    published_year int NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);