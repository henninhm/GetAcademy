select customers.id, customers.name, customers.email, orders.id as order_id
from customers inner join orders
on customers.id = orders.customer_id