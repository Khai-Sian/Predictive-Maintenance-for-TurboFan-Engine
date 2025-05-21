# Predictive Maintenance Dashboard  

## Project Overview  
This project aims to develop a **Predictive Maintenance (PdM) Dashboard** using **Machine Learning (ML)** to forecast the **Remaining Useful Life (RUL)** of equipment, particularly **turbofan engines**. Traditional maintenance strategies such as **Run-To-Failure (R2F)** and **Preventive Maintenance (PvM)** can be costly and inefficient. This dashboard utilizes **data-driven** approaches to optimize maintenance schedules, improve productivity, and reduce operational costs.  

## Dataset  
The project uses the **C-MAPSS turbofan engine dataset** from NASA, which contains **historical sensor measurements** collected from engines under varying conditions. The dataset includes:  
- **Engine ID** – Unique identifier for each engine  
- **Cycle** – Number of operational cycles completed  
- **Operational Settings (3 features)** – Adjustable settings influencing engine performance  
- **Sensor Measurements (21 features)** – Real-time condition readings of the engine  
- **Target Variable** – **Remaining Useful Life (RUL)**, indicating time before engine failure  

## Data Processing Steps  
### 1. Exploratory Data Analysis (EDA)  
- Statistical analysis of sensor readings to understand degradation patterns.  
- Heatmaps and correlation matrices to identify **highly relevant features**.  
- Removal of constant-value sensors for efficiency.  

### 2. Feature Engineering  
- **Manual feature selection** based on correlation with RUL.  
- **Principal Component Analysis (PCA)** to reduce dimensionality while retaining essential information.  

### 3. Model Training  
The project implements several **machine learning algorithms** to predict RUL:  
- **Linear Regression** (baseline model)  
- **Polynomial Regression**  
- **Support Vector Regression (SVR)**  
- **Random Forest Regression**  
- **Gradient Boosting Regression (GBR)** (*final model selected*)  

### 4. Hyperparameter Tuning  
- **Randomized Search** for optimizing parameters.  
- **Grid Search** for fine-tuning hyperparameters.  

## Dashboard Development  
The dashboard provides **real-time equipment monitoring** with the following features:  
- **RUL Prediction Visualization** – Displays estimated lifespan for each engine.  
- **Sensor Data Display** – Shows latest sensor readings from monitored engines.  
- **Model Performance Comparison** – Users can toggle between different trained models and view performance metrics.  
- **Speech Recognition** – Enables voice commands to switch views and control dashboard functions.  
- **Lock Screen Feature** – Prevents unauthorized access to sensitive data.  

## Technologies Used  
- **Python** (Data Analysis & ML Modeling)  
  - NumPy, Pandas, Scikit-learn, Matplotlib  
- **C# with Visual Studio** (Dashboard Development)  
- **SQL Server** (Data Storage & Retrieval)  

## Key Findings  
- **GBR outperforms other models**, achieving an RMSE of **17.34** and R² of **0.83**, making it the best predictive model.  
- **Feature selection significantly improves accuracy**, ensuring only relevant sensor data is utilized.  
- **PdM strategies reduce maintenance costs** while improving operational efficiency.  

## Future Improvements  
- Implement **deep learning models** such as **LSTM** or **CNN** for better time-series predictions.  
- Enhance **speech recognition** for improved command accuracy.  
- Allow users to **upload and test new models** dynamically within the dashboard.  

## Conclusion  
This project successfully integrates **Machine Learning** with **Predictive Maintenance**, providing valuable insights to optimize equipment maintenance and enhance industrial productivity. The dashboard serves as a **decision-support tool** for engineers, helping prevent unplanned failures and minimize downtime.  

---
