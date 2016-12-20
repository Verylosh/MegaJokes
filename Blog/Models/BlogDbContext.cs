﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Blog.Models
{
    public class BlogDbContext : IdentityDbContext<ApplicationUser>
    {
        public BlogDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public virtual IDbSet<Article> Articles { get; set; }

        public virtual IDbSet<Category> Categories { get; set; }

        public virtual IDbSet<Comment> Comments { get; set; }
        
        public virtual IDbSet<Tag> Tags { get; set; }

        public static BlogDbContext Create()
        {
            return new BlogDbContext();
        }

        public System.Data.Entity.DbSet<Blog.Models.ApplicationUser> ApplicationUsers { get; set; }
    }
}