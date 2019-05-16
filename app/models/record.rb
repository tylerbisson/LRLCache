class Record < ApplicationRecord

    validates :title, presence: true
    validates :artist, presence: true 

    belongs_to :user

    # has_one_attached :art 
end