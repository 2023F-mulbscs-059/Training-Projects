 padding: 2rem;
  color: #4b0082;
}  


.intro {
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin-bottom: 1.5rem;
}

.intro h2 {
  margin: 0;
  font-size: 1.8rem;
  color: #7f56d9;
}

.get-code-btn {
  background-color: #7f56d9;
  color: white;
  padding: 10px 20px;
  border: none;
  border-radius: 8px;
  cursor: pointer;
  font-size: 1rem;
}

.tabs {
  display: flex;
  flex-wrap: wrap;
  gap: 10px;
  margin-bottom: 30px;
}

.tab {
  padding: 10px 20px;
  background-color: #e0d7f5;
  color: #4b0082;
  border: none;
  border-radius: 8px;
  cursor: pointer;
}

.tab.active {
  background-color: #7f56d9;
  color: #fff;
}

.container {
  display: flex;
  flex-wrap: wrap;
  gap: 20px;
}

.card {
  display: none;
  background-color: #ffffff;
  border-radius: 12px;
  padding: 20px;
  box-shadow: 0 5px 15px rgba(127, 86, 217, 0.15);
  flex: 1;
  min-width: 300px;
}

.card.active {
  display: block;
}

.card h3 {
  color: #7f56d9;
  margin-bottom: 15px;
}

label {
  display: block;
  margin-top: 10px;
  font-weight: bold;
}

input, textarea {
  width: 100%;
  padding: 10px;
  margin-top: 5px;
  border: 1px solid #d5c9f0;
  border-radius: 8px;
  background-color: #fdfbff;
}

.radio-group {
  display: flex;
  gap: 20px;
  margin-top: 10px;
}

.button {
  background-color: #7f56d9;
  color: #fff;
  padding: 10px 20px;
  border: none;
  border-radius: 8px;
  margin-top: 20px;
  cursor: pointer;
}

.upload-box {
  border: 2px dashed #c3b4ec;
  padding: 20px;
  text-align: center;
  background: #f9f7ff;
  border-radius: 10px;
  margin-top: 10px;
}

@media (max-width: 768px) {
  .container {
    flex-direction: column;
  }

  .intro {
    flex-direction: column;
    align-items: flex-start;
    gap: 10px;
  }

  .get-code-btn {
    align-self: stretch;
  }
}
