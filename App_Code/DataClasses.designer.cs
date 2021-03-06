﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SmartBussinessCloud")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void Insertuser(user instance);
  partial void Updateuser(user instance);
  partial void Deleteuser(user instance);
  partial void InsertuserApp(userApp instance);
  partial void UpdateuserApp(userApp instance);
  partial void DeleteuserApp(userApp instance);
  partial void Insertcategory(category instance);
  partial void Updatecategory(category instance);
  partial void Deletecategory(category instance);
  partial void Insertapp(app instance);
  partial void Updateapp(app instance);
  partial void Deleteapp(app instance);
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SmartBussinessCloudConnectionString1"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<user> users
	{
		get
		{
			return this.GetTable<user>();
		}
	}
	
	public System.Data.Linq.Table<userApp> userApps
	{
		get
		{
			return this.GetTable<userApp>();
		}
	}
	
	public System.Data.Linq.Table<category> categories
	{
		get
		{
			return this.GetTable<category>();
		}
	}
	
	public System.Data.Linq.Table<app> apps
	{
		get
		{
			return this.GetTable<app>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[user]")]
public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _u_id;
	
	private string _firstname;
	
	private string _lastname;
	
	private string _email;
	
	private string _password;
	
	private string _wallpaper;
	
	private EntitySet<userApp> _userApps;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onu_idChanging(int value);
    partial void Onu_idChanged();
    partial void OnfirstnameChanging(string value);
    partial void OnfirstnameChanged();
    partial void OnlastnameChanging(string value);
    partial void OnlastnameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnwallpaperChanging(string value);
    partial void OnwallpaperChanged();
    #endregion
	
	public user()
	{
		this._userApps = new EntitySet<userApp>(new Action<userApp>(this.attach_userApps), new Action<userApp>(this.detach_userApps));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_u_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int u_id
	{
		get
		{
			return this._u_id;
		}
		set
		{
			if ((this._u_id != value))
			{
				this.Onu_idChanging(value);
				this.SendPropertyChanging();
				this._u_id = value;
				this.SendPropertyChanged("u_id");
				this.Onu_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string firstname
	{
		get
		{
			return this._firstname;
		}
		set
		{
			if ((this._firstname != value))
			{
				this.OnfirstnameChanging(value);
				this.SendPropertyChanging();
				this._firstname = value;
				this.SendPropertyChanged("firstname");
				this.OnfirstnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastname", DbType="NVarChar(50)")]
	public string lastname
	{
		get
		{
			return this._lastname;
		}
		set
		{
			if ((this._lastname != value))
			{
				this.OnlastnameChanging(value);
				this.SendPropertyChanging();
				this._lastname = value;
				this.SendPropertyChanged("lastname");
				this.OnlastnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string email
	{
		get
		{
			return this._email;
		}
		set
		{
			if ((this._email != value))
			{
				this.OnemailChanging(value);
				this.SendPropertyChanging();
				this._email = value;
				this.SendPropertyChanged("email");
				this.OnemailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string password
	{
		get
		{
			return this._password;
		}
		set
		{
			if ((this._password != value))
			{
				this.OnpasswordChanging(value);
				this.SendPropertyChanging();
				this._password = value;
				this.SendPropertyChanged("password");
				this.OnpasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wallpaper", DbType="NVarChar(50)")]
	public string wallpaper
	{
		get
		{
			return this._wallpaper;
		}
		set
		{
			if ((this._wallpaper != value))
			{
				this.OnwallpaperChanging(value);
				this.SendPropertyChanging();
				this._wallpaper = value;
				this.SendPropertyChanged("wallpaper");
				this.OnwallpaperChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_userApp", Storage="_userApps", ThisKey="u_id", OtherKey="u_id")]
	public EntitySet<userApp> userApps
	{
		get
		{
			return this._userApps;
		}
		set
		{
			this._userApps.Assign(value);
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_userApps(userApp entity)
	{
		this.SendPropertyChanging();
		entity.user = this;
	}
	
	private void detach_userApps(userApp entity)
	{
		this.SendPropertyChanging();
		entity.user = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.userApp")]
public partial class userApp : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private int _u_id;
	
	private int _app_id;
	
	private EntityRef<user> _user;
	
	private EntityRef<app> _app;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onu_idChanging(int value);
    partial void Onu_idChanged();
    partial void Onapp_idChanging(int value);
    partial void Onapp_idChanged();
    #endregion
	
	public userApp()
	{
		this._user = default(EntityRef<user>);
		this._app = default(EntityRef<app>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_u_id", DbType="Int NOT NULL")]
	public int u_id
	{
		get
		{
			return this._u_id;
		}
		set
		{
			if ((this._u_id != value))
			{
				if (this._user.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onu_idChanging(value);
				this.SendPropertyChanging();
				this._u_id = value;
				this.SendPropertyChanged("u_id");
				this.Onu_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_app_id", DbType="Int NOT NULL")]
	public int app_id
	{
		get
		{
			return this._app_id;
		}
		set
		{
			if ((this._app_id != value))
			{
				if (this._app.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onapp_idChanging(value);
				this.SendPropertyChanging();
				this._app_id = value;
				this.SendPropertyChanged("app_id");
				this.Onapp_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_userApp", Storage="_user", ThisKey="u_id", OtherKey="u_id", IsForeignKey=true)]
	public user user
	{
		get
		{
			return this._user.Entity;
		}
		set
		{
			user previousValue = this._user.Entity;
			if (((previousValue != value) 
						|| (this._user.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._user.Entity = null;
					previousValue.userApps.Remove(this);
				}
				this._user.Entity = value;
				if ((value != null))
				{
					value.userApps.Add(this);
					this._u_id = value.u_id;
				}
				else
				{
					this._u_id = default(int);
				}
				this.SendPropertyChanged("user");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="app_userApp", Storage="_app", ThisKey="app_id", OtherKey="app_id", IsForeignKey=true)]
	public app app
	{
		get
		{
			return this._app.Entity;
		}
		set
		{
			app previousValue = this._app.Entity;
			if (((previousValue != value) 
						|| (this._app.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._app.Entity = null;
					previousValue.userApps.Remove(this);
				}
				this._app.Entity = value;
				if ((value != null))
				{
					value.userApps.Add(this);
					this._app_id = value.app_id;
				}
				else
				{
					this._app_id = default(int);
				}
				this.SendPropertyChanged("app");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.category")]
public partial class category : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _cat_id;
	
	private string _cat_name;
	
	private string _cat_description;
	
	private string _cat_image;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncat_idChanging(int value);
    partial void Oncat_idChanged();
    partial void Oncat_nameChanging(string value);
    partial void Oncat_nameChanged();
    partial void Oncat_descriptionChanging(string value);
    partial void Oncat_descriptionChanged();
    partial void Oncat_imageChanging(string value);
    partial void Oncat_imageChanged();
    #endregion
	
	public category()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cat_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int cat_id
	{
		get
		{
			return this._cat_id;
		}
		set
		{
			if ((this._cat_id != value))
			{
				this.Oncat_idChanging(value);
				this.SendPropertyChanging();
				this._cat_id = value;
				this.SendPropertyChanged("cat_id");
				this.Oncat_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cat_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string cat_name
	{
		get
		{
			return this._cat_name;
		}
		set
		{
			if ((this._cat_name != value))
			{
				this.Oncat_nameChanging(value);
				this.SendPropertyChanging();
				this._cat_name = value;
				this.SendPropertyChanged("cat_name");
				this.Oncat_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cat_description", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string cat_description
	{
		get
		{
			return this._cat_description;
		}
		set
		{
			if ((this._cat_description != value))
			{
				this.Oncat_descriptionChanging(value);
				this.SendPropertyChanging();
				this._cat_description = value;
				this.SendPropertyChanged("cat_description");
				this.Oncat_descriptionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cat_image", DbType="NVarChar(50)")]
	public string cat_image
	{
		get
		{
			return this._cat_image;
		}
		set
		{
			if ((this._cat_image != value))
			{
				this.Oncat_imageChanging(value);
				this.SendPropertyChanging();
				this._cat_image = value;
				this.SendPropertyChanged("cat_image");
				this.Oncat_imageChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.app")]
public partial class app : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _app_id;
	
	private string _app_name;
	
	private string _link;
	
	private string _logo_path;
	
	private string _app_info;
	
	private string _category;
	
	private string _app_description;
	
	private EntitySet<userApp> _userApps;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onapp_idChanging(int value);
    partial void Onapp_idChanged();
    partial void Onapp_nameChanging(string value);
    partial void Onapp_nameChanged();
    partial void OnlinkChanging(string value);
    partial void OnlinkChanged();
    partial void Onlogo_pathChanging(string value);
    partial void Onlogo_pathChanged();
    partial void Onapp_infoChanging(string value);
    partial void Onapp_infoChanged();
    partial void OncategoryChanging(string value);
    partial void OncategoryChanged();
    partial void Onapp_descriptionChanging(string value);
    partial void Onapp_descriptionChanged();
    #endregion
	
	public app()
	{
		this._userApps = new EntitySet<userApp>(new Action<userApp>(this.attach_userApps), new Action<userApp>(this.detach_userApps));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_app_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int app_id
	{
		get
		{
			return this._app_id;
		}
		set
		{
			if ((this._app_id != value))
			{
				this.Onapp_idChanging(value);
				this.SendPropertyChanging();
				this._app_id = value;
				this.SendPropertyChanged("app_id");
				this.Onapp_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_app_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string app_name
	{
		get
		{
			return this._app_name;
		}
		set
		{
			if ((this._app_name != value))
			{
				this.Onapp_nameChanging(value);
				this.SendPropertyChanging();
				this._app_name = value;
				this.SendPropertyChanged("app_name");
				this.Onapp_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_link", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string link
	{
		get
		{
			return this._link;
		}
		set
		{
			if ((this._link != value))
			{
				this.OnlinkChanging(value);
				this.SendPropertyChanging();
				this._link = value;
				this.SendPropertyChanged("link");
				this.OnlinkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_logo_path", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string logo_path
	{
		get
		{
			return this._logo_path;
		}
		set
		{
			if ((this._logo_path != value))
			{
				this.Onlogo_pathChanging(value);
				this.SendPropertyChanging();
				this._logo_path = value;
				this.SendPropertyChanged("logo_path");
				this.Onlogo_pathChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_app_info", DbType="NVarChar(MAX)")]
	public string app_info
	{
		get
		{
			return this._app_info;
		}
		set
		{
			if ((this._app_info != value))
			{
				this.Onapp_infoChanging(value);
				this.SendPropertyChanging();
				this._app_info = value;
				this.SendPropertyChanged("app_info");
				this.Onapp_infoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category", DbType="NVarChar(50)")]
	public string category
	{
		get
		{
			return this._category;
		}
		set
		{
			if ((this._category != value))
			{
				this.OncategoryChanging(value);
				this.SendPropertyChanging();
				this._category = value;
				this.SendPropertyChanged("category");
				this.OncategoryChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_app_description", DbType="NVarChar(MAX)")]
	public string app_description
	{
		get
		{
			return this._app_description;
		}
		set
		{
			if ((this._app_description != value))
			{
				this.Onapp_descriptionChanging(value);
				this.SendPropertyChanging();
				this._app_description = value;
				this.SendPropertyChanged("app_description");
				this.Onapp_descriptionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="app_userApp", Storage="_userApps", ThisKey="app_id", OtherKey="app_id")]
	public EntitySet<userApp> userApps
	{
		get
		{
			return this._userApps;
		}
		set
		{
			this._userApps.Assign(value);
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_userApps(userApp entity)
	{
		this.SendPropertyChanging();
		entity.app = this;
	}
	
	private void detach_userApps(userApp entity)
	{
		this.SendPropertyChanging();
		entity.app = null;
	}
}
#pragma warning restore 1591
