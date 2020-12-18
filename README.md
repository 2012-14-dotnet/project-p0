# pizzabox

The goal of the project is to build a Pizza Ordering System.

## architecture (REQUIRED)

+ [solution] PizzaBox.sln
  + [project - console] PizzaBox.Client.csproj
  + [project - classlib] PizzaBox.Domain.csproj
    + [folder] Abstracts
    + [folder] Interfaces
    + [folder] Models
  + [project - classlib ] PizzaBox.Storing.csproj
    + [folder] Repositories
  + [project - xunit] PizzaBox.Testing.csproj
    + [folder] Tests

## requirements

The project should support objects of User, Store, Order, Pizza.

### store

+ [required] there should exist at least 2 stores for a user to choose from
+ [required] each store should be able to view/list any and all of their completed/placed orders
+ [required] each store should be able to view/list any and all of their sales (amount of revenue weekly or monthly)

### order

+ [required] each order must be able to view/list/edit its collection of pizzas
+ [required] each order must be able to compute its pricing
+ [required] each order must be limited to a total pricing of no more than $250
+ [required] each order must be limited to a collection of pizzas of no more than 50

### pizza

+ [required] each pizza must be able to have a crust
+ [required] each pizza must be able to have a size
+ [required] each pizza must be able to have toppings
+ [required] each pizza must be able to compute its pricing
+ [required] each pizza must have no less than 2 default toppings
+ [required] each pizza must limit its toppings to no more 5

### user

+ [required] must be able to view/list its order history
+ [required] must be able to only order from 1 location in a 24-hour period with no reset
+ [required] must be able to only order once every 2-hour period

## technologies

+ .NET Core - C#
+ .NET Core - EF + SQL
+ .NET Core - xUnit

## timelines

+ due on Dec-28 at 11p Central
+ present on Dec-30 starting at 9.30a Central
+ implement as many requirements as you can (don't push to get all done)

## as a customer

I should be able to:

+ access the application
+ see a list of stores
+ select a store
+ place an order
+ with either custom or preset pizzas
+ if custom
+ select crust, size and toppings
+ if preset
+ select pizza and its size
+ see a tally of my order
+ add or remove more pizzas
+ and checkout when complete with latest order
+ see my order history
+ make a new order

## store story

as a store, i should be able do this:

+ access the application
+ select options for order history, sales
+ if order history
+ select options for all store orders and orders associated to a user (filtering)
+ if sales
+ see pizza type, count, revenue by week or by month

> the goal is to try to complete as many reqs as you can in the time alloted. :)
