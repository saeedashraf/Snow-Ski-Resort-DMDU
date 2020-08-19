# EMA-interpretation of the model and figures

Model runs from 1981-1-1 to 2099-12-31

### Variables and parameters
The following variables are arguments of the function **snow_model()** which is called by the EMA-workbench.

Climate e**X**ternalities/uncertainties:      
**xRCP** : (from 0.51 to 3.49) Represents the concentration pathway (i.e. the climate scenario), either RCP2.6, RCP4.5 or RCP8.5  
Is rounded to a value 1, 2 or 3?  
**xClimateModel** : (from 0 to 1) Represents the climate model  

Model e**X**ternalities/uncertainties:  ?What do these represent?  
**X2fM** : (from 1.01 to 1.61)  
**X3iPt** : (from 900 to 1100)   
**X5temp** : (from 0 to 6.0)   
**X6tempArt** : (from -2.0 to -1.0)  ??? Temperature at which we start making articial snow?  

Constants:  
*xCostDay* : (constant) 
*xRevenueDay* : (constant)  
*Xfactor1* : (constant) 
*X4rSnow* : (constant) 

Policy **L**evers:  
**s1SnowThershold** : ?? The point where we start making artifical snow ??  
**xGoodDays** : Threshold for number of good snow conditions for making a profit?  

Returns:  
*y*  : AveragesumRows (Scalar) ~ something with artificial snow making (from 20 to 120)  
*y1* : climateModel (Scalar) ~ the (input???) climate model?  (from 0 to 70)  
*y3* : sumRows (Array) ~ the number of tipping points per year? (from 2500 to 13,000)  
*y4* : AveragesumRowsArtSnow (Scalar) ~ summary of days with artifical snow making? (from 5000 to 10,000)  
*y5* : AveragesumRowsProfit (Scalar) ~ average of days in which profit is made? (from 0 to -150)  
*y6* : AveragereportMatrix (Scalar) ~ ?? (from 0.1 to 0.8)  

## Visualisations
These are for Hoch-Ybrig 
### Scatter pair plot:
grouped by policy gives 40 results, how are these composed?  
Metrics *y* and *y3* have a perfect linear relation, so I would guess on of them is superfluous  

### Scenario Discovery/PRIM
Find subregions of the input space with *M*etric values of interest.  
Apparantly searching for outcomes['y'] < 50 -> TRUE  
Assume: TRUE means tipping point.  
In the pairs scatter plot with the boxes I can see: clear box of outcomes around X5temp  

### Feature scoring  
Feature scoring diagram (~block 45). This is sort of a regression test between input (X,L) parameters and outcome metrics (M)
As we also saw in the SD: the FS shows that Metric *y* is very sensitive to changes in the X5te  
Metric *y1* is very sensitive to the chosen RCP.  
Metrics *y3*, *y5* and *y6* behave similar as *y*  
Metric *y4* is sensitive to *xRCP* and *X6tempArt*.  
It seems that the policy **Levers** do **not** have any serious impact on the results: *policy*, *x1SnowThreshold* and *xGoodDays* have little effect on outcome parameters. 

Questions:
Why implement xRCP as RealParameter, in practice it can only have 3 discrete values? Maybe easier with the IntegerParameter (0,1,2) or CategoricalParameter ('RCP26','RCP45','RCP85') ?  
