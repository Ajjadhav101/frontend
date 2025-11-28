document.addEventListener('DOMContentLoaded', function () {
    fetch('/api/invoice')
        .then(resp => resp.json()({
  "items": [
    { "name": "Laptop", "price": 999.99 },
    { "name": "Mouse", "price": 25.50 }
  ]
}
        .then(data => {
            let html = '<ul>';
            data.items.forEach(item => {
                html += `<li>${item.name} - 
                $${item.price}</li>`;
            });
            html += '</ul>';
            document.getElementById('invoice-container').innerHTML = html;
        })
        .catch(err => console.error("Failed to load invoice:", err));
});
