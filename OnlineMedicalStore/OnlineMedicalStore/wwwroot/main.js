async function loginUser(email, password) {
         const response = await fetch('/api/login', {
             method: 'POST',
             headers: {
                 'Content-Type': 'application/json'
             },
             body: JSON.stringify({ email: email, password: password })
         });

         if (response.ok) {
             window.location.href = "/home";
         } else {
            const res = await response.text();
            console.error(res);
            alert(res);
             alert('Inv');
         }
     }