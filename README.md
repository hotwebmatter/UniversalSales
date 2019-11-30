# UniversalSales
Final assignment to be submitted via Blackboard for C# class.

## Example output (name not found)
```
$ dotnet bin/Debug/netcoreapp2.1/UniversalSales.dll
************************
Display all sales
Name    Jan     Feb     Mar
Collier 2500    35000   20000
Lee     17000   50000   10000
Brown   13000   25000   25000
Cano    55000   35000   30000

************************

************************
Enter sales month (1, 2, or 3): xxx
Invalid input. Enter sales month (1, 2, or 3): 3
Total for month $85,000.00

************************
Enter name: xxxxx
Name xxxxx not found
```


## Example output (name found)
```$ dotnet bin/Debug/netcoreapp2.1/UniversalSales.dll
************************
Display all sales
Name    Jan     Feb     Mar
Collier 2500    35000   20000
Lee     17000   50000   10000
Brown   13000   25000   25000
Cano    55000   35000   30000

************************

************************
Enter sales month (1, 2, or 3): 3
Total for month $85,000.00

************************
Enter name: lee
Sales for LEE are $77,000.00
```
