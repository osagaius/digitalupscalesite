using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web;

/// <summary>
/// Models a list of customer objects.
/// </summary>
public class CustomerList
{
    /// <summary>
    /// The list of customers
    /// </summary>
    private readonly List<Customer> _customerList;


    /// <summary>
    /// Initializes a new instance of the <see cref="CustomerList"/> class.
    /// </summary>
    public CustomerList()
    {
        this._customerList = new List<Customer>();
    }

    /// <summary>
    /// Gets the count.
    /// </summary>
    /// <value>
    /// The count.
    /// </value>
    public int Count
    {
        get { return this._customerList.Count; }
    }

    /// <summary>
    /// Gets or sets the <see cref="Customer" /> at the specified index.
    /// </summary>
    /// <value>
    /// The <see cref="Customer" />.
    /// </value>
    /// <param name="index">The index.</param>
    /// <returns></returns>
    public Customer this[int index]
    {
        get { return this._customerList[index]; }
        set
        {
            Trace.Assert(value != null);
            this._customerList[index] = value;
        }
    }

    /// <summary>
    /// Gets the <see cref="Customer" /> with the specified name.
    /// </summary>
    /// <value>
    /// The <see cref="Customer" />.
    /// </value>
    /// <param name="name">The identifier.</param>
    /// <returns></returns>
    public Customer this[string name]
    {
        get
        {
            foreach (var currentCustomer in this._customerList)
            {
                if (currentCustomer.Name.Equals(name))
                {
                    return currentCustomer;
                }
            }
            return null;
        }
    }

    /// <summary>
    /// Gets the list of customers from the session object.
    /// </summary>
    /// <returns></returns>
    public static CustomerList GetCustomers()
    {
        var list = (CustomerList)HttpContext.Current.Session["ContactList"];
        if (list == null)
            HttpContext.Current.Session["ContactList"] = new CustomerList();
        return (CustomerList)HttpContext.Current.Session["ContactList"];
    }

    /// <summary>
    /// Adds the customer.
    /// </summary>
    /// <param name="newCustomer">The new customer.</param>
    public void AddItem(Customer newCustomer)
    {
        this._customerList.Add(newCustomer);
    }


    /// <summary>
    /// Removes the customer at the specified index.
    /// </summary>
    /// <param name="index">The index.</param>
    public void RemoveAt(int index)
    {
        this._customerList.RemoveAt(index);
    }

    /// <summary>
    /// Clears this instance.
    /// </summary>
    public void Clear()
    {
        this._customerList.Clear();
    }
}