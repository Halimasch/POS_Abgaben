function getAllProducts() {

    fetch('./api/Product')
        .then(response => response.json())
        .then(data => {
            let html = '';
            data.forEach(d => html += `<tr><td>${d.id}</td><td>${d.name}</td>
                                       <td><button onclick="getDetails(${d.id})">Details</button></td></tr>`);
            document.getElementById('product_table').innerHTML = html;
        });
}

function getDetails