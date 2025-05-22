function showTab(tab, event) {
  const cards = document.querySelectorAll('.card');
  const tabs = document.querySelectorAll('.tab');
  tabs.forEach(t => t.classList.remove('active'));
  event.target.classList.add('active');


