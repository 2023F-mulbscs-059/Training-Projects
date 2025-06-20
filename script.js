view
view
 document.querySelectorAll('.card');
  const tabs = document.querySelectorAll('.tab');
  tabs.forEach(t => t.classList.remove('active'));
  event.target.classList.add('active');

  cards.forEach(card => {
    const type = card.getAttribute('data-type');
    if (type.includes(tab) || tab === 'all') {
      card.classList.add('active');
    } else {
      card.classList.remove('active');
    }
  });
}

