# Snow-Ski-Resort-DMDU
This project analyses the impact of climate change on the financial situation and tipping points of Ski resorts.


## Case Studies:
In total six ski resortes were selcted for this study:

1. https://www.sattel-hochstuckli.ch/en  (800m to 1200) - Central Switzerland
2. https://www.hoch-ybrig.ch/en/winter/service/brochure/  (900-1900) Central Switzerland
3. https://www.atzmaennig.ch/en/winter/  (800-1200) Zurich Region
4. https://www.villars-diablerets.ch/en/ (1200-3000)
5. https://www.champex.info/ (1486-2194)
6. https://www.davos.ch/winter/berge/jakobshorn/ (1500 - 2500)


## Input Datasets:
CH2018 [link](https://www.nccs.admin.ch/nccs/en/home/the-nccs/priority-themes/ch2018-climate-scenarios.html)


## Framework:
<details>
<summary>T1 - <i><b>Climate Data</b></i></summary>

### Topics
`CH2018`

In this task, the data of located climate grids inside each Ski resorts are extracted from CH2018 datasets. 

###  Literature
CH2018 "Switzerland CH2018 climate scenarios" [here](https://www.nccs.admin.ch/nccs/en/home/the-nccs/priority-themes/ch2018-climate-scenarios.html)
</details>


<details>
<summary>T2 - <i><b>Snow Model</b></i></summary>

### Topics
`Snow model` `Ablation` `Accumulation` 

In this task, a modular grid-based snow model was developed. The current model consists of Ablation, and Accumulation modules, with the possibility of adding new modules in the future. The main 

###  Literature
Marty (2017) "How much can we save? Impact of different emission scenarios on future snow cover in the Alps" [link](https://www.the-cryosphere.net/11/517/2017/)

Farinotti (2012) "Runoff evolution in the Swiss Alps: projections for selected high-alpine catchments based on ENSEMBLES scenarios" [link](https://onlinelibrary.wiley.com/doi/abs/10.1002/hyp.8276)

Huss (2008a) "Determination of the seasonal mass balance of four Alpine glaciers since 1865" [link](https://agupubs.onlinelibrary.wiley.com/doi/full/10.1029/2007JF000803)

Huss (2008b) "Modelling runoff from highly glacierized alpine drainage basins in a changing climate" [link](https://onlinelibrary.wiley.com/doi/10.1002/hyp.7055)

Hock (2005)"Glacier melt: a review of processes and their modelling" [link](https://journals.sagepub.com/doi/10.1191/0309133305pp453ra)


###  Notebooks 
No1. [snowModel version 2](snowmodel_py/snow_model_v2.ipynb)
</details>


<details>
<summary>T3 - <i><b>Snow Model post processing</b></i></summary>

### Topics
`Visualization of snow model results` `Visualization of tipping points`

###  Notebooks
No2. [Visualization of snow model](snowModel2_Visualization.ipynb)

No3. [Visualization of snow model with elevation bands](snowModel2_Visualization_elevBand.ipynb)
</details>

<details>
<summary>T4 - <i><b>Deep uncertainty in climate scenarios</b></i></summary>

### Topics
`Deep Uncertainy`

In this task a paython code was developed to produce new climate scenarios based on CH2018 dataset

###  Literature
van Ginkel et al (2020), "Climate change induced socio-economic tipping points" [link](https://iopscience.iop.org/article/10.1088/1748-9326/ab6395)

Kwakkel (2017), "The Exploratory Modeling Workbench: An open source toolkit for exploratory modeling, scenario discovery, and (multi-objective) robust decision making"  [link](https://www.sciencedirect.com/science/article/pii/S1364815217301251)

Damm et al (2014), "Does artificial snow production pay under future climate conditions?"[link](https://www.sciencedirect.com/science/article/abs/pii/S0261517714000107?via%3Dihub)

###  Notebooks
No4. [Randomness notebook](randomness_tmp_pcp.ipynb)

No5. [Visualization of snow model outputs](snowModel2_randomness_Visualization.ipynb)

No6. [Visualization of snow model outpts with elevation bands](snowModel2_randomness_Visualization_elevBand.ipynb)
</details>

<details>
<summary>T5 - <i><b>Decision Making under Deep Uncertainty</b></i></summary>

### Topics
`Deep Uncertainy` `Decision Making`

In this task, a python code will be developed to connect our existing notebooks (No.1, No.4) to the Exploratory Modelling and Analysis (EMA) Workbench [here](https://emaworkbench.readthedocs.io/en/latest/)

###  Literature
van Ginkel et al (2020), "Climate change induced socio-economic tipping points" [link](https://iopscience.iop.org/article/10.1088/1748-9326/ab6395)

Kwakkel (2017), "The Exploratory Modeling Workbench: An open source toolkit for exploratory modeling, scenario discovery, and (multi-objective) robust decision making"  [link](https://www.sciencedirect.com/science/article/pii/S1364815217301251)

Damm et al (2014), "Does artificial snow production pay under future climate conditions?"[link](https://www.sciencedirect.com/science/article/abs/pii/S0261517714000107?via%3Dihub)

###  Notebooks
No7. [snowModel version 2_EMA-workbench](snowmodel_py/snow_model_v2_ema_workbench.ipynb)

No8. [snowModel version 2-3_EMA-workbench](snowmodel_py/snow_model_v2-3_ema_workbench.ipynb)

No9. [snowModel version 2-5_CH2018_EMA-workbench](snowmodel_py/snow_model_vcloned_v2_5_ch2018_ema_workbench.ipynb)

No10. [snowModel version 2-5_EMA-workbench](snowmodel_py/snow_model_vcloned_v2_5_ema_workbench.ipynb)

</details>

## Jupyter Notebooks:
No1. [snowModel version 1](snowmodel_py/snow_model_v1.ipynb)

No2. [Visualization of snow model](snowModel2_Visualization.ipynb)

No3. [Visualization of snow model with elevation bands](snowModel2_Visualization_elevBand.ipynb)

No4. [Randomness notebook](randomness_tmp_pcp.ipynb)

No5. [Visualization of snow model outputs](snowModel2_randomness_Visualization.ipynb)

No6. [Visualization of snow model outpts with elevation bands](snowModel2_randomness_Visualization_elevBand.ipynb)

No7. [snowModel version 2_EMA-workbench](snowmodel_py/snow_model_v2_ema_workbench.ipynb)

No8. [snowModel version 2-3_EMA-workbench](snowmodel_py/snow_model_v2-3_ema_workbench.ipynb)

No9. [snowModel version 2-5_CH2018_EMA-workbench](snowmodel_py/snow_model_vcloned_v2_5_ch2018_ema_workbench.ipynb)

No10. [snowModel version 2-5_EMA-workbench](snowmodel_py/snow_model_vcloned_v2_5_ema_workbench.ipynb)

## Outputs:
The results of the snow model (csv format) for the case studies are collected [here](data_out_snow). In these analyses, no elevation bands were considered for Villars-Diablerets and Jakobshorn case studies. 

After considering elevation bands (500m) for the case study No.4 (Villars-Diableret) and No.6 ( Jakobshorn), new results were generated and stored [here](data_out_snow_villars-diablerets_elev_band), and [here](/data_out_snow_davos_elev_band).

After considering the uncertainty of climate scenarios by producing 68 new climate scenarios [here](data_out_randomness_snow) and runing the snow model, the new results were stored [here](data_out_randomness_snow), [here](data_out_snow_randomness_davos_elev_band), and [here](data_out_snow_randomness_villars-diablerets_elev_band).

