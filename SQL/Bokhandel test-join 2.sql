select books.id, books.title, authors.name
from books inner join authors
on books.author_id = authors.id