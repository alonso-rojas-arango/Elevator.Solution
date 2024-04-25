using System.ComponentModel;

namespace Elevator.Model.InsideRequestList
{
  public class InsideRequestListModel : List<InsideRequestModel>, INotifyPropertyChanged
  {
    public InsideRequestListModel(List<InsideRequestModel> insideRequests) : base(insideRequests) { }
    public InsideRequestModel this[int index]
    {
      get
      {
        return base[index];
      }
      set
      {
        base[index] = value;
        OnPropertyChanged("InsideRequestModel");
      }
    }

    public int Count => base.Count;

    #region handle property changes

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
      PropertyChangedEventHandler handler = PropertyChanged;
      if (handler != null)
        handler(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, string propertyName)
    {
      if (EqualityComparer<T>.Default.Equals(field, value))
        return false;
      field = value;
      OnPropertyChanged(propertyName);
      return true;
    }

    #endregion

    public void Add(InsideRequestModel item)
    {
      base.Add(item);
      OnPropertyChanged("Add");
    }

    public void Clear()
    {
      base.Clear();
      OnPropertyChanged("Clear");
    }

    public bool Contains(InsideRequestModel item)
    {
      return base.Contains(item);
    }

    public void CopyTo(InsideRequestModel[] array, int arrayIndex)
    {
      base.CopyTo(array, arrayIndex);
    }

    public IEnumerator<InsideRequestModel> GetEnumerator()
    {
      return base.GetEnumerator();
    }

    public int IndexOf(InsideRequestModel item)
    {
      return base.IndexOf(item);
    }

    public void Insert(int index, InsideRequestModel item)
    {
      base.Insert(index, item);
    }

    public bool Remove(InsideRequestModel item)
    {
      return base.Remove(item);
    }

    public void RemoveAt(int index)
    {
      base.RemoveAt(index);
    }

  }
}
