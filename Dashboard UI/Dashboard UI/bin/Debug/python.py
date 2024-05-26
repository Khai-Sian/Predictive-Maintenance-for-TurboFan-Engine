import sys
import os
import pandas as pd
import pickle


sensor_names = ['SensorMeasure{}'.format(i) for i in range(1,22)] 
sub = "base_model"

modelFile = sys.argv[1] 
sensor = list(map(float, sys.argv[2].split(',')))
df = pd.DataFrame ([sensor], columns = sensor_names)

if sub in modelFile:
	model = pickle.load(open(modelFile, 'rb'))

	RUL = model.predict(df)

else:

	scalerFile = os.getcwd() + "\model\std_scaler.pkl"
	scaler = pickle.load(open(scalerFile, 'rb'))

	pcaFile = os.getcwd() + "\model\pca.pkl"
	pca = pickle.load(open(pcaFile, 'rb'))

	model = pickle.load(open(modelFile, 'rb'))

	data = scaler.transform(df)

	data = pd.DataFrame(data, columns = sensor_names).reset_index(drop = True)

	data = pca.transform(data)

	RUL = model.predict(data)

print(RUL[0])
