﻿using Mojio.Platform.SDK.Contracts.ActivityStreams;

namespace Mojio.Platform.SDK.Entities.ActivityStreams
{

    /// <summary>
    /// URI:	http://www.w3.org/ns/activitystreams#Application	
    /// Notes:	Describes a software application.
    /// Extends:	Actor
    /// Properties:	Inherits all properties from Actor.
    /// </summary>
    public class Application : Actor, IApplication
    {
        public Application()
        {
            Context = "http://www.w3.org/ns/activitystreams#Application";
            Type = "Application";
        }
    }

    /// <summary>
    /// URI:	http://www.w3.org/ns/activitystreams#Group	
    /// Notes:	Represents a formal or informal collective of Actors.
    /// Extends:	Actor
    /// Properties:	Inherits all properties from Actor.
    /// </summary>
    public class Group : Actor, IGroup
    {
        public Group()
        {
            Context = "http://www.w3.org/ns/activitystreams#Group";
            Type = "Group";

        }
    }

    /// <summary>
    /// URI:	http://www.w3.org/ns/activitystreams#Organization	
    /// Notes:	Represents an organization.
    /// Extends:	Actor
    /// Properties:	Inherits all properties from Actor.
    /// </summary>
    public class Organization : Actor, IOrganization
    {
        public Organization()
        {
            Context = "http://www.w3.org/ns/activitystreams#Organization";
            Type = "Organization";
        }
    }

    /// <summary>
    /// URI:	http://www.w3.org/ns/activitystreams#Person	
    /// Notes:	Represents an individual person.
    /// Extends:	Actor
    /// Properties:	Inherits all properties from Actor.
    /// </summary>
    public class Person : Actor, IPerson
    {
        public Person()
        {
            Context = "http://www.w3.org/ns/activitystreams#Person";
            Type = "Person";

        }
    }

    /// <summary>
    /// URI:	http://www.w3.org/ns/activitystreams#Service	
    /// Notes:	Represents a service of any kind.
    /// Extends:	Actor
    /// Properties:	Inherits all properties from Actor.
    /// </summary>
    public class Service : Actor, IService
    {
        public Service()
        {
            Context = "http://www.w3.org/ns/activitystreams#Service";
            Type = "Service";

        }
    }
}