// InvoiceApps.MvcClient/wwwroot/js/main.js
$(function () {
    const apiBase = "https://localhost:5001/api"; // adjust port if needed

    $('#btnLoad').click(async function () {
        try {
            const res = await fetch(apiBase + '/employees');
            const data = await res.json();
            renderEmployees(data);
        } catch (e) { showMessage("Error loading employees: " + e); }
    });

    $('#btnLoadSP').click(async function () {
        try {
            const res = await fetch(apiBase + '/employees/via-sp');
            const data = await res.json();
            renderEmployees(data);
        } catch (e) { showMessage("Error loading via SP: " + e); }
    });

    // external product list integration
    $('#btnProducts').click(async function () {
        try {
            const res = await fetch('https://www.pqstec.com/InvoiceApps/values/GetProductListAll');
            const data = await res.json();
            let html = '<ul>';
            data.forEach(p => html += `<li>${p.ProductName ?? p.Name ?? JSON.stringify(p)}</li>`);
            html += '</ul>';
            $('#products').html(html);
        } catch (e) { showMessage("Error loading external products: " + e); }
    });

    $('#btnUpload').click(async function () {
        const f = $('#fileUpload')[0].files[0];
        if (!f) return showMessage("Select file");
        const fd = new FormData();
        fd.append('file', f);
        try {
            const res = await fetch(apiBase + '/files/upload', {
                method: 'POST',
                body: fd
            });
            const data = await res.json();
            showMessage("Uploaded: " + data.fileName);
        } catch (e) { showMessage("Upload error: " + e); }
    });

    $('#frmEmployee').submit(async function (e) {
        e.preventDefault();
        const emp = {
            id: Number($('#Id').val() || 0),
            firstName: $('#FirstName').val(),
            lastName: $('#LastName').val(),
            email: $('#Email').val(),
            departmentId: Number($('#DepartmentId').val() || 0),
            designationId: Number($('#DesignationId').val() || 0)
        };
        try {
            if (emp.id === 0) {
                const res = await fetch(apiBase + '/employees', {
                    method: 'POST',
                    headers: { 'Content-Type': 'application/json' },
                    body: JSON.stringify(emp)
                });
                const created = await res.json();
                showMessage('Created id: ' + created.id);
            } else {
                await fetch(apiBase + '/employees/' + emp.id, {
                    method: 'PUT',
                    headers: { 'Content-Type': 'application/json' },
                    body: JSON.stringify(emp)
                });
                showMessage('Updated');
            }
            $('#frmEmployee')[0].reset();
            $('#btnLoad').click();
        } catch (err) { showMessage(err); }
    });

    window.renderEmployees = function (data) {
        const $b = $('#tblEmployees tbody').empty();
        data.forEach(e => {
            const name = e.lastName ? `${e.firstName} ${e.lastName}` : e.firstName;
            $b.append(`<tr>
                <td>${e.id}</td>
                <td>${name}</td>
                <td>${e.email}</td>
                <td>${e.department?.name ?? ''}</td>
                <td>${e.designation?.title ?? ''}</td>
                <td>
                  <button class="del" data-id="${e.id}">Delete</button>
                  <button class="edit" data-id="${e.id}">Edit</button>
                </td>
            </tr>`);
        });

        $('.del').click(async function(){
            const id = $(this).data('id');
            if (!confirm('Delete?')) return;
            await fetch(apiBase + '/employees/' + id, { method: 'DELETE' });
            $('#btnLoad').click();
        });

        $('.edit').click(function(){
            const id = $(this).data('id');
            window.location = '/Employee/Edit/' + id;
        });
    };

    function showMessage(msg) {
        $('#messages').text(msg);
        setTimeout(()=> $('#messages').text(''), 5000);
    }
});
